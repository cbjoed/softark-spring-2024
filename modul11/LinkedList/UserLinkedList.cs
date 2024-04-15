namespace LinkedList
{
    class Node
    {
        public Node(User data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
        public User Data;
        public Node Next;
    }

    class UserLinkedList
    {
        private Node first = null!;

        public void AddFirst(User user)
        {
            Node node = new Node(user, first);
            first = node;
        }

        public User RemoveFirst()
        {
            // TODO: Implement!
            if (first == null)
            {
                return null!;
            }

            User user = first.Data;
                first = first.Next;
                return user;
           
        }

        public void RemoveUser(User user)
        {
            Node current = first;
            Node previous = null!;
            bool found = false;

            while (!found && current != null)
            {
                if (current.Data.Name == user.Name)
                {
                    found = true;
                    if (current == first)
                    {
                        RemoveFirst();
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                }
                else
                {
                    previous = current;
                    current = current.Next;
                }
            }
        }

        public User GetFirst()
        {
            return first.Data;
        }

        public User GetLast()
        {
        
        Node current = first;
            while (current.Next != null)
            {
                
                current = current.Next;
                
            }
            return current.Data;
        }

        public int CountUsers()
        {
            int count = 0;
            Node current = first;
            while (current != null)
            {
                count++;
                current = current.Next;
                
            }
            return count;
        }

        public override String ToString()
        {
            Node node = first;
            String result = "";
            while (node != null)
            {
                result += node.Data.Name + ", ";
                node = node.Next;
            }
            return result.Trim();
        }
        public bool Contains(User user)

        {
            Node nextNode = first;

            if (first == null)
            {
                return false;
            }
            while (nextNode != null)
            {
                if (nextNode.Data.Name == user.Name)
                {
                    return true;
                }
                nextNode = nextNode.Next;


            }
            return false;
        }
    }
}