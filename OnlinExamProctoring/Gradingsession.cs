using System;
using System.IO;

namespace OnlinExamProctoring
{
    public class GradingSession : IDisposable
    {
        private StreamWriter resultsWriter;
        private StreamWriter flaggedWriter;
        private bool disposed = false;

        public GradingSession(string resultsFile, string flaggedFile)
        {
            resultsWriter = new StreamWriter(resultsFile);
            flaggedWriter = new StreamWriter(flaggedFile);
        }

        public void WriteResult(string message)
        {
            resultsWriter.WriteLine(message);
            resultsWriter.Flush();
        }

        public void WriteFlagged(string message)
        {
            flaggedWriter.WriteLine(message);
            flaggedWriter.Flush();
        }
        public void FlushResults()
        {
            resultsWriter.Flush();
        }

        public void FlushFlagged()
        {
            flaggedWriter.Flush();
        }
        public void Dispose()
        {
            if (disposed)
                return;

            try
            {
                if (resultsWriter != null)
                {
                    resultsWriter.Flush();
                    resultsWriter.Close();
                }
            }
            catch
            {
                // Continue so flaggedWriter is also closed
            }

            try
            {
                if (flaggedWriter != null)
                {
                    flaggedWriter.Flush();
                    flaggedWriter.Close();
                }
            }
            catch
            {
                // Defensive disposal
            }

            disposed = true;
            GC.SuppressFinalize(this);
        }

        ~GradingSession()
        {
            Dispose();
        }
    }
}