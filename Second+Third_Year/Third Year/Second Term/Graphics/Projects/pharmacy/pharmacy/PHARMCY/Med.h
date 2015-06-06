#ifndef MedInclude
#define MedInclude
#include<iostream>
#include<string>
#include"Record.h"
using namespace std;

class Med :public Record
{
 public:
	 double m_Price;
	 char m_Name[30];
	 int m_Number;
     int m_SNumber;
	 char m_Company_name[30];
	 int m_CompanyNum;
	 char type[12];

	Med();
	virtual ~Med();
};
#endif 


