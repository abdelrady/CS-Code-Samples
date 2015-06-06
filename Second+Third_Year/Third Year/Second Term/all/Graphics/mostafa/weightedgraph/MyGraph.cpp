#include<fstream.h>
#include<process.h>
typedef int ktype;
/****structure***/
struct eltype
{
	char name;
	ktype key;
	void showdata()
	{
		cout<<name<<"\t"<<key<<endl;
	}
};


const float infinity = 1000;
const int max=100;
/***  class graph*************/
class graph
{
   private:
	   int count;
	   eltype nodes[max];
	   float edges[max][max];
   public:
	   //the constructor
	   graph()
	   {
		   count=0;
	   }
	   //return count
	   int getcount()
	   {
		   return count;
	   }
	   ktype getkey(int i)
	   {
		   return nodes[i].key;
	   }
	   //graph full
	   bool graph_is_full()
	   {
		   return (count==max)?true:false;
	   }
	   //graph empety
	   bool graph_is_empety()
	   {
		   return (count==0)?true:false;
	   }
	   //key found
	   bool keyfound(ktype k)
	   {
		   int i;
		   for(i=0;i<=count;i++)
		   if(nodes[i].key==k)
			   return true;
		   return false;
	   }
	   //find node
	   int findnode(ktype k)
	   {
		   int i;
		   for(i=0;i<=count;i++)
		   if(nodes[i].key==k)
			   return i;
		   return -1;
	   }
	   //insertnode
	   void insertnode(eltype e)
	   {
		   if(graph_is_full())
		   {
			   cout<<"Error graph_is_full\n";
			   return;
		   }
		   if(keyfound(e.key))
		   { 
		   	   cout<<"Error Duplicate key found\n";
			   return;
		   }
		   nodes[count]=e;
		   for(int i=0;i<=count;i++)
		   { 
		       edges[i][count] = infinity;
			   edges[count][i] = infinity;
		   }
		   edges[count][count] = 0;
		   count++;
	   }
	   //delete node
	   void deletenode(eltype e)
	   {
		   if(graph_is_empety())
		   {
			   cout<<"Error graph_is_empety\n";
			   return;
		   }
		   count--;
		   int where=findnode(e.key);
		   if(where==-1)
		   {
			   cout<<"Error key is found\n";
			   return;
		   }
          
		   for(int i=0;i<=count;i++)
		   { 
		       edges[where][i]=edges[count][i];
			   edges[i][where]=edges[i][count];
		   }
		   edges[where][where]=edges[count][count];
		   
	   }
	   //updata node
	   bool updatenode(eltype e)
	   {
		   int i=findnode(e.key);
			   if(i==-1)
			   {
				cout<<"Error update missing key\n";
			   return false;
			   }
			   nodes[i]=e;
	   }
	   //insertedge
	   void insertedge(ktype k1,ktype k2,float d)
	   {
		   int n1=findnode(k1);
		   int n2=findnode(k2);
		   if(n1==-1||n2==-1)
		   {
			   cout<<"Error the node that you want to connect is missing\n";
			   return;
		   }
		   edges[n1][n2]=d;
		   edges[n2][n1]=d;
	   
	   }
	   //delete edge
	   void deleteedge(ktype k1,ktype k2)
	   {
		   int n1=findnode(k1);
		   int n2=findnode(k2);
		   if(n1==-1||n2==-1)
		   {
			   cout<<"Error the node that you want to remove edge is missing\n";
			   return;
		   }
		   edges[n1][n2]=0;
		   edges[n2][n1]=0;
	   }
	   // is adjesnt
	   bool isadjacent(ktype k1, ktype k2)
	   {
		   int n1=findnode(k1);
		   int n2=findnode(k2);
		   if(n1==-1||n2==-1)
		   {
			   cout<<"Error the node that you want to remove edge is missing\n";
			   exit(0);
		   }
		   if(edges[n1][n2] > 0 &&  edges[n1][n2] < infinity)
			   return true;
		   else
			   return false;
	   }
	   //display graph
	   void displaygraph()
	   {
		   for(int i=0;i<count;i++)
			   nodes[i].showdata();
		   cout << endl << endl;

		   for(i=0;i<count;i++)
		   {
			   for(int j=0;j<count;j++)
				   cout<<edges[i][j]<<"\t";
				   cout<<endl;
		   }
	   }
	   //retriveedge
	   float retriveedge(ktype k1,ktype k2)
	   {
		   int n1=findnode(k1);
		   int n2=findnode(k2);
		   if(n1==-1||n2==-1)
		   {
			   cout<<"Error the node that you want to remove edge is missing\n";
			   exit(0);
		   }
		   return edges[n1][n2];
	   }

};
///////////////***********build graph**************////////////////
void build_graph(graph&g)
{
	eltype e1,e2;
	float dis;
	char* filename="graph.txt";
	ifstream file(filename);
	if(!file)
	{
		cout<<"Error file error\n";
		return;
	}
	while(file>>e1.key)
	{
		file>>e1.name;
		if(g.keyfound(e1.key))
			g.updatenode(e1);
		else
			g.insertnode(e1);
		
			char ch;
			while(file.get(ch)&&ch!='\n')
			{
				file>>e2.key;
				file>>dis;
				if(!g.keyfound(e2.key))
					g.insertnode(e2);
				g.insertedge(e1.key,e2.key,dis);
			}
	}
}
/**********showmenu**********/
int showmenu()
{
	int i;
	cout<<"1-Insert Node\n";
	cout<<"2-Update Node\n";
	cout<<"3-Display bgraph\n";
	cout<<"4-Shortest Path\n";                     
	cout<<"5-Exit\n";                     
	cout<<"                  Enter choice:  ";
	cin>>i;
	return i;
}
//************** get shortest path********//////////
void getpath(graph g)
{
	float distance[max];
	int fromnode[max];
	bool processed[max];
     	distance[0]=0;
		processed[0]=true;
		fromnode[0]=-1;

		int n=g.getcount();
    ////////////////////////////// initialization
	for(int i=1;i< n; i++)
	{
		if(g.isadjacent(0,i))
		{
			distance[i]=g.retriveedge(0,i);
			fromnode[i]=0;
		}
		else
		{
			distance[i]=infinity;
			fromnode[i]=-1;
		}
			
		processed[i]=false;
			
	}


	
	int indexmin;
	float sum;
		float mindis;
	
	for(i=0;i<=n-1;i++)
	{
		
		mindis=2*infinity;
		// find the indexmin
		for(int k=1;k<=n-1;k++)
		{
			if(!processed[k])
			{
				if(distance[k]<mindis)
				{
					indexmin=k;
					mindis=distance[k];
				}	
			}
		} //end inner loop


		processed[indexmin]=true;

		for(int j=1;j<=n-1;j++)
		{
			if(!processed[j] && g.isadjacent(j,indexmin))
			{
				
				sum=g.retriveedge(j,indexmin)+distance[indexmin];

				if(sum<distance[j])
				{

					distance[j]=sum;
					fromnode[j]=indexmin;
				}
				
			}
			

		}//end inner loop
	}//end outer loop
  
	for (i = 0; i< n; i++)
	{
		cout << distance[i] << "\t" ;
	}
	cout << endl <<endl;
	
	for (i = 0; i< n; i++)
	{
		cout << fromnode[i] << "\t" ;
	}
	cout << endl <<endl;
	

	for (i = 0; i< n; i++)
	{
		cout << processed[i] << "\t" ;
	}
	cout << endl <<endl;
	
	//cout<<"the shortest path is   "<<distance[n-1]<<endl;	


	cout<<"The Shortest Path is  ";
	cout<<distance[n-1]<<endl<<endl;
	cout<<n-1<<"  ";
	int x=fromnode[n-1];
	for(int h=n-1;h>=0;h++)
	{
		
		if(x==0)
		{
			cout<<x<<endl<<endl;
			return;
		}
		cout<<x<<"   ";
		x=fromnode[x];
	}
}//end getpath

/***************main****************/
int main()
{
	graph g;
	eltype e;
	build_graph(g);
	g.displaygraph();
	int n; bool flag=true;;
	while(flag)
	{


     n=showmenu();
	switch(n)
	{
	case 1:
		cout<<"Enter the key :  ";
		cin>>e.key;
		if(g.keyfound(e.key))
		{
			exit(0);
		}
		cout<<"Enter the name :  ";
		cin>>e.name;
		g.insertnode(e);
		cout<<"Enter the keys of the conected edges (1) if you want to connect or (0) otherwise ";
		int i;
		float x;
		for(i=0;i<g.getcount();i++)
		{
			cout<<"do you want to connect this node with node whose key is ";
			cout<<g.getkey(i);
			cin>>x;
			if(x!=0)
				g.insertedge(e.key,g.getkey(i),x);
			else
				continue;
		}
		break;
	case 2:
        cout<<"Enter the key :  ";
		cin>>e.key;
		if(!g.keyfound(e.key))
		{
			cout<<"Canot update not found key\n";
			exit(0);
		}
		cout<<"Enter the name :  ";
		cin>>e.name;
		g.updatenode(e);
		break;
	case 3:
		g.displaygraph();
		break;
	case 4:
		getpath(g); 
		break;
	case 5:
		flag=false;
		break;
	default:
		cout<<"error\n";
		
	}

		
	}
	return 0;
	
}
	
