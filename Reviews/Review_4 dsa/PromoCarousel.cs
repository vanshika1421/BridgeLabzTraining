using System;

namespace DSA_Test
{
    public class PromoCarousel
    {
        private PromotionNode head;
        private PromotionNode current;

        public void AddPromotion(string promotion)
        {
            PromotionNode newNode =
                new PromotionNode(promotion);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                current = head;
                return;
            }

            PromotionNode temp = head;

            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
        }

        public string NextPromotion()
        {
            if (head == null)
            {
                return null;
            }

            string promotion = current.Promotion;

            current = current.Next;

            return promotion;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void PrintPromotions()
        {
            if (head == null)
            {
                Console.WriteLine("No promotions available.");
                return;
            }

            PromotionNode currentNode = head;

            do
            {
                Console.WriteLine(currentNode.Promotion);

                currentNode = currentNode.Next;

            } while (currentNode != head);
        }
    }
}