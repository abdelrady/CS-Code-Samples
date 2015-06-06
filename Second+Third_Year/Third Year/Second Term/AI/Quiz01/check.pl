check( [H] ).
check( [H|T] ):-
	[X|Y] = T,
	H < X,
	check( T ).