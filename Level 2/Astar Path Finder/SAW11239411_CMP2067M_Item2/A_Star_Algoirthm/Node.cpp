#include <iostream>
#include <Windows.h>
#include <fstream>
#include <string>
#include "Node.h"
using namespace std;

Node::Node(double input_data)
{
	GCost = 0;
	HCost = 0;
	FCost = GCost + HCost;
	Data = input_data;
	x = 0;
	y = 0;
	Parent = -1;
}

Node::Node(const Node& existingNode)
{
	FCost = existingNode.get_FCost();
	GCost = existingNode.get_GCost();
	HCost = existingNode.get_HCost();
	Data = existingNode.get_Data();
	x = existingNode.get_x();
	y = existingNode.get_y();
	Parent = existingNode.get_Parent();
}

Node ::~Node()
{
}

double Node::get_FCost() const
{
	return FCost;
}

double Node::get_GCost() const
{
	return GCost;
}

double Node::get_HCost() const
{
	return HCost;
}

double Node::get_Data() const
{
	return Data;
}

int Node::get_Parent() const
{
	return Parent;
}

const void Node::set_GCost(double G)
{
	GCost = G;
	//cout<<G<<endl;
	//cout<<GCost<<endl;
	FCost = GCost + HCost;
}

const void Node::set_HCost(double H)
{
	if (H < 0)
	{
		H = H*-1;
		HCost = H;
		FCost = GCost+ HCost;
	}
	else 
	{
		HCost = H;
		FCost = GCost+ HCost;
	}
}

int Node::get_x() const
{
	return x;
}

int Node::get_y() const
{
	return y;
}

const void Node::set_x(int X)
{
	x = X;
}

const void Node::set_y(int Y)
{ 
	y = Y;
}

const void Node::set_Parent(int K)
{
	if (Parent == -1)
	{
		Parent = K;
	}

	else Parent = Parent;
}

bool Node::operator==(const Node& T)
{
	if (x == T.get_x() && y == T.get_y())
	{
		return true;
	}

	else 

		return false;
}



