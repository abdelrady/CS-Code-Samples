sum([],A,0).
sum([H|T],A,S):- 
	H is A+1,
	B is A+1,
	C is S-H,
sum(T,B,C).
