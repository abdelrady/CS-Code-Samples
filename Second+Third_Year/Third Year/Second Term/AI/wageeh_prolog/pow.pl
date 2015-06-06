pow(X,1,X).
pow(X,Y,P):-
R is Y-1,
pow(X,R,M),
P is M*X.