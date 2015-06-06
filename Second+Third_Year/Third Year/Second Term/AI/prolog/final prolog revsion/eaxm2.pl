p(X,Y):-
	q(X,Y),!,r(Y).
p(X,c):-
	s(X).
q(e,Z):- !,Z=d.
q(W,V).
r(a).
r(b):-!.
r(d).
s(g).