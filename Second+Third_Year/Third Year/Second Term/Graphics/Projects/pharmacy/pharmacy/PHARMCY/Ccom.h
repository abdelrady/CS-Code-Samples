#ifndef CcomInclude
#define CcomInclude
#include<iostream>
#include<string>
#include"Record.h" 
using namespace std;

class Ccom : public Record
{
public:
	char m_comname[50];
	char m_headname[50];
	char m_address[100];
	int m_phonenum;
	int m_mobilenum;
	Ccom();
	virtual ~Ccom();
};

#endif 



