#include<iostream>
#include<Windows.h>
#include<fstream>
#include<string>
#include<iomanip>
#include<list>
#include<algorithm>
#include"Methods.h"
using namespace std;

int main()
{
	char* filepath = "TEST2.txt"; //Change to your own file path
	int mapRow = 20;  //change to correct size
	int mapColumn = 25;  //change to correct size
	double* tempGrid = readTXT(filepath, mapRow, mapColumn);
	Grid * map = new Grid(mapRow,mapColumn);
	for (int ii = 0; ii<mapRow; ii++)
	{
		for (int jj = 0; jj <mapColumn; jj++)
		{
			double t = tempGrid[ii*mapColumn+jj];
			Node * tempNode = new Node(t);
			tempNode->set_x(ii);
			tempNode->set_y(jj);
			map->set(ii,jj, tempNode);
		}
	}
	cout<<"Displaying Original Grid: "<<endl;
	map->displayGrid();
	int startx;
	int starty;
	int endx;
	int endy;
	cout<<"Input start X: ";
	cin>>startx;
	cout<<endl<<"Input start Y: ";
	cin>>starty;
	cout<<endl<<"Input goal X: ";
	cin>>endx;
	cout<<endl<<"Input goal Y: ";
	cin>>endy;
	map->setHur(endx,endy);
	Node * current = new Node(map->get_node(startx, starty));
	Node * end = new Node(map->get_node(endx, endy));
	Sleep(1000);
	list<Node> OpenList;
	list<Node> ClosedList;
	while (true)
	{
		if (*current == *end)
		{
			break;
		}
		list<Node> Neighbour;
		ClosedList.push_front(*current);
		for(int ii = -1; ii <= 1; ii++)
		{
			for(int jj = -1; jj <= 1; jj++)
			{
				int neighX = current->get_x() + ii;
				int neighY = current->get_y() + jj;
				if (neighX < 0) continue;
				if (neighX > map->get_Row()) continue;
				if (neighY < 0) continue;
				if (neighY > map->get_Column()) continue;
				if ((neighX == current->get_x()) && (neighY ==current->get_y())) continue;
				if (map->get_node(neighX,neighY).get_Data() == 1)
				{
					if ((ii == -1 && jj == -1)||(ii==1 && jj ==1)||(ii== -1 && jj== 1)||(ii == 1 && jj == -1))
					{
						double t = 14+current->get_GCost();
						int K = current->get_x()* map->get_Column()+current->get_y();
						map->setCost(neighX, neighY,t, K);
					}
					else
					{
						double t = 10 + current->get_GCost();
						int K = current->get_x()* map->get_Column()+current->get_y();
						map->setCost(neighX, neighY,t, K);
					} 
					OpenList.push_front((map->get_node(neighX,neighY)));
					Neighbour.push_front((map->get_node(neighX,neighY)));
				}
				else continue;
			}
		}
		OpenList.unique();

		for(list<Node> :: iterator cloIt = ClosedList.begin(); cloIt != ClosedList.end(); cloIt++)
		{
			for(list<Node> :: iterator opIt = OpenList.begin(); opIt != OpenList.end();)
			{
					if (*cloIt == *opIt)
					{
                    opIt = OpenList.erase(opIt);

					}

					else 
					{
						opIt++;
					}
				for(list<Node> :: iterator neigIt = Neighbour.begin(); neigIt != Neighbour.end();)
				{
					if (*cloIt == *neigIt)
					{
					    neigIt = Neighbour.erase(neigIt);
					}

					else 
					{
						neigIt++;
					}
				}
			}
		}

		double bestCost = -1;
		Node temp = Node();
		for(list<Node> :: iterator openiter = Neighbour.begin(); openiter != Neighbour.end(); openiter++)
		{
			if(bestCost == -1)
			{
				bestCost = openiter->get_FCost();
				temp = *openiter;
			}

			else if( openiter->get_FCost() < bestCost)
			{
				bestCost = openiter->get_FCost();
				temp = *openiter;
			}
		}

		delete current;
		OpenList.remove(temp);
		current = new Node(temp);
	}

	Node result = Node(*current);
	while(true)
	{
		if (result.get_x()== startx && result.get_y() == starty)
		{
			break;
		}
		else
		{
			int k = result.get_x() * map->get_Column() + result.get_y();
			int  c = result.get_Parent();
			map->upDate(k, 3.0);
			result = map->get_node(c);
		}

	}
	int k = startx * mapColumn + starty;
	map->upDate(k, 4.0);
	k = endx * mapColumn + endy;
	map->upDate(k, 4.0);
	cout<<endl<<"Ouputing result: "<<endl;
	map->displayGrid();
	Sleep(10000);
	return 0;
}
