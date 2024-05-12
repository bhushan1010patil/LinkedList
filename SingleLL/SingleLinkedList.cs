namespace SingleLL;

public class SingleLinkedList
{
    private Node? start;
    public SingleLinkedList()
    {
        start = null;
    }

    public void InsertAtStart(int data)
    {
        Node temp = new Node(data);
        temp.link = start;
        start = temp;
    }


    public void InsertAtEnd(int data)
    {
        Node temp = new Node(data);
        if(start == null){
            start = temp;
            return; 
        }

        Node p = start;
        while(p.link != null)
            p = p.link;
        
        p.link = temp;
    }

    public void DisplayList()
    {
        if(start == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        Node? p = start;
        Console.Write("List elements are :  ");
        while(p != null)
        {
            Console.Write(p.info + "  ");
            p = p.link;
        }
        Console.WriteLine();
    }

    public void countNodes()
    {
        int n =0;
        Node? p = start;
        while(p != null)
        {
            n++;
            p = p.link;
        }

        Console.Write("No of nodes are : " + n);
    }

    public bool search(int x)
    {
        if(start == null)
        {
            Console.WriteLine("List is empty");
            return false;
        }
        else{
            Node? p = start;
            int pos = 1;
            while(p != null)
            {
                if(p.info == x)
                    break;
                
                p = p.link;
                pos++;
            }

            if(p==null)
            {
                Console.WriteLine(x + " not found in list");
                return false;
            }
            else
            {
                Console.WriteLine(x + " is at position " + pos);
                return true;                
            }    
        }
    }
}
