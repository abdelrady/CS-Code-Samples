get([],0).
get([H|X],N):-
   get(X,L),
     N is L+1.
