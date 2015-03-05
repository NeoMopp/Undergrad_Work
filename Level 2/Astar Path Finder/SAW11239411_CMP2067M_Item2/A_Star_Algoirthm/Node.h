#pragma
#ifndef NODE_H
#define NODE_H

class Node
{
protected:
	protected:
	double FCost;
	double GCost;
	double HCost;
	double Data;
	int x;
	int y;
	int Parent;

public:
	Node(double input_Data);
	Node() { FCost = 0; GCost = 0; HCost = 0; Data = 0; x = 0; y = 0; Parent = -1;}
	~Node();
	Node(const Node& existingNode);
	double get_FCost() const;
	double get_GCost() const;
	double get_HCost() const;
	double get_Data() const;
	int get_x() const;
	int get_y() const;
	int get_Parent() const;
	const void set_GCost(double G); 
	const void set_HCost(double H);
	const void set_x(int X);
	const void set_y(int Y);
	const void set_Parent(int K);
	const void set_Data(double t) { Data = t;};
	bool operator == (const Node& T);
};

#endif