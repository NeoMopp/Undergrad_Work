#pragma
#ifndef Grid_H
#define Grid_H
#include "Node.h"
 
class Grid
{
protected:
	int Row;
	int Column;
	Node* node;
	Grid() { Row = 0; Column = 0; node = new Node(0);}

public:
	Grid(int R, int C, Node* input_node);
	Grid(int R, int C);
	~Grid();
	Node get_node(int i, int j) const;
	Node get_node(int ii) const;
	int get_Row() const;
	int get_Column() const;
	const void set (int i, int  j, Node* input_node);
	const void set (int ii, Node* input_node);
	void displayGrid();
	void setHur(int endX, int endY);
	void setCost(int X, int Y, double t, int K);
	void upDate (int k, double t);
};

#endif