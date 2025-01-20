public static Node<int>[] Makearr(Node<int> L)
        {
            Node<int>[] arr = new Node<int>[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Node<int>(0); // made new list in array 
            }
            
            while (L.GetNext()!=null)
            {
                int index = L.GetValue() / 10;
                arr[index].SetNext(new Node<int>(L.GetValue()));
                L = L.GetNext();

            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].GetNext();
                Node<int> temp = arr[i];
                int max = arr[i].GetValue();
                while (arr[i].GetNext()!=null)
                {
                    if (arr[i].GetValue() > max)
                        max = arr[i].GetValue();

                }
                Node<int> adder = new Node<int>(max);
                adder.SetNext(temp);

                Delete(arr[i], max);

            }
            return arr;
        }
        public static Node<int> NewLst(Node<int> lst, int i)
        {
            Node<int> deme = new Node<int>(0);
            Node<int> temp = deme;
            Node<int> temp1 = lst;
            if(temp1!=null)
            {
                if(temp1.GetValue()/10==i)
                {
                    temp.SetNext(new Node<int>(temp1.GetValue()));
                    temp = temp.GetNext();

                }
                temp1 = temp1.GetNext();

            }
            return deme.GetNext();
        }
        public static Node<int> Delete(Node<int> lst, int max)
        {
            Node<int> temp = lst;
            while(temp.GetNext()!=null)
            {
                if (temp.GetNext().GetValue() == max)
                    temp.SetNext(temp.GetNext().GetNext());
                else
                    temp = temp.GetNext();
            }
            return lst;
        }
        public static Node<int>[] arrlst(Node<int> lst)
        {
            Node<int>[] arr = new Node<int>[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = NewLst(lst, i);
            }
            return arr; 
        }