factorial( 1, 1 ).
factorial( X, F ):-
	Q is X-1,
	factorial( Q, Temp ),
	F is X * Temp.