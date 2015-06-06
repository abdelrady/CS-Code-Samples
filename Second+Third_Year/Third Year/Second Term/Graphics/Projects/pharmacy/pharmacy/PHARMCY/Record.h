// Record.h: interface for the Record class.
//
//////////////////////////////////////////////////////////////////////

#if !defined RecoreInclude
#define RecoreInclude
typedef /*unsigned*/ int uint;
class RFS;
class Record  
{
public :
	uint RecordNumber;

	bool active;		//lazy delete
	friend class RFS;
public:
	Record();
	virtual ~Record();
	bool isActive()	{return active;}
};

#endif 
