reverse(L1,L2):-
	rev(L1,L2*[]).
rev([],L*L).
rev([H|T],L*NT):-
	rev(T,L*[H|NT]).