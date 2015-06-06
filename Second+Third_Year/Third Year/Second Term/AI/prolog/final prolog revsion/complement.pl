complement([E],[-E]).
complement([-E],[E]).
complement([H|T],[H1|T1]):-
	H<0,
	H1 is H*(-1),
	H>0,
	H1 is H*(-1),
	complement(T,T1).