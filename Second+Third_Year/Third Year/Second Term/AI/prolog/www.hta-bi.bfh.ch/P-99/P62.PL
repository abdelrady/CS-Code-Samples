% P62 (*) Count the leaves of a binary tree

:- ensure_loaded(p57).

% count_leaves(T,N) :- the binary tree T has N internal nodes

count_leaves(nil,0).
count_leaves(t(_,nil,nil),1) :- !.  % sorry for the red cut!
count_leaves(t(_,L,R),N) :-  
	count_leaves(L,NL),
	count_leaves(R,NR),
	N is NL + NR.
