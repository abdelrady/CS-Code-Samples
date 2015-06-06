len([H|T],H,1).
len([H|x],E,N):-
len(X,E,L),
N is L+1.