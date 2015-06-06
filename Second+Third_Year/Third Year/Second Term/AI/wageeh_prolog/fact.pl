fact(0,1).
fact(X,N):-
Y is X-1,
fact(Y,M),
N is M*X.