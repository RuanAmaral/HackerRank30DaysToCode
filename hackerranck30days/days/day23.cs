using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class day23Node{
    public day23Node left,right;
    public int data;
    public day23Node(int data){
        this.data=data;
        left=right=null;
    }
}
class day23Solution{

	static void day23levelOrder(day23Node root){
  		//Write your code here
          var queue = new Queue<day23Node>();
          queue.Enqueue(root);
          while(queue.Count>0){
              var node = queue.Dequeue();
              if (node is null) continue;
              Console.Write($"{node.data} ");
              
              queue.Enqueue(node.left);
              queue.Enqueue(node.right);
          }
    }

	static day23Node insert(day23Node root, int data){
        if(root==null){
            return new day23Node(data);
        }
        else{
            day23Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    static void day23Main(){
        day23Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        day23levelOrder(root);
        
    }
}