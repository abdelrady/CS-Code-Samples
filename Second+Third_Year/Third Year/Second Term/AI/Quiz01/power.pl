power( X, 1, X ).
power( X, Y, Z):-
	Q is Y-1,
	power( X, Q, R ),
	Z is R * X.