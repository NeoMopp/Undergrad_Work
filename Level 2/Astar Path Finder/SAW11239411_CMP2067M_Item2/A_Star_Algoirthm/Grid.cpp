#include <iostream>
#include <Windows.h>
#include <fstream>
#include <string>
#include "Grid.h"
#include "Node.h"
using namespace std;

Grid::Grid(int R, int C, Node* input_node)
{
	Row = R;
	Column = C;
	node = new Node[R*C];
	for (int ii =0; ii<R; ii++)
	{
		for (int jj = 0; jj <C; jj++)
		{
			node[ii*C+jj] = input_node[ii*C+jj];
			node[ii*C+jj].set_x(ii);
			node[ii*C+jj].set_y(jj);
		}
	}
}

Grid::Grid(int R, int C)
{
	Row = R;
	Column = C;
	node = new Node[R*C];
	for (int ii = 0; ii < R*C; ii++)
	{
		node[ii] = Node();
	}
}

Grid::~Grid()
{
	delete [] node;
}

Node Grid::get_node(int i, int j) const
{
	return node[i*Column+j];
}

Node Grid::get_node(int ii) const
{
	return node[ii];
}

int Grid::get_Row() const
{
	return Row;
}

int  Grid::get_Column() const
{
	return Column;
}

const void Grid::set(int i, int  j, Node* input_node)
{
	node[i*Column+j] = *input_node;
}

const void Grid::set(int ii, Node* input_node)
{
	node[ii] = *input_node;
}

void Grid::displayGrid()
{
	for (int r = -1; r <= Row; r++)
	{
		for (int c = -1; c <= Column; c++)
		{
			if (r == -1 && c == -1)
			{
				cout<<(char)201;
			}

			 else if (r == Row && c == Column)
			{
				cout<<(char)188;
			}

			else if (r == -1 && c == Column)
			{
				cout<<(char)187;
			}

			else if (r == Row && c == -1)
			{
				cout<<(char)200;
			}

			else if (r == -1 || r == Row )
			{
				cout<<(char)205;
			}

			else if (c==-1 ||c == Column)
			{
				cout<<(char)186;
			}
			
			else if (node[r*Column+c].get_Data() == 0)
			{
				cout<<(char)178;
			}
			else if (node[r*Column+c].get_Data() == 3)
			{
				cout<<'*';
			}

			else if (node[r*Column+c].get_Data() ==4)
			{
				cout<<'s';
			}

			else
			{
				cout<<' ';
			}
		}
		cout<<endl;
		
	}
}


void Grid::setHur(int endX, int endY)
{
	for(int x = 0; x <= Row; x++)
	{
		for(int y = 0; y <= Column; y++)
		{
			int t = (endX - x) + (endY - y);
			t = t*10;
			node[x*Column+y].set_HCost(t);
		}
	}
}

void Grid::setCost(int X, int Y, double t, int K)
{
	node[X*Column+Y].set_GCost(t);
	node[X*Column+Y].set_Parent(K);
}

void Grid::upDate(int k, double t)
{
	node[k].set_Data(t);
}