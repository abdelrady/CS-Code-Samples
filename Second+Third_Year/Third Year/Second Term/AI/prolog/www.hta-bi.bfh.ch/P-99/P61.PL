% P61 (*) Count the internal nodes of a binary tree

:- ensure_loaded(p57).

% internal_node(V) :- V is an internal node

internal_node(t(_,L,R)) :- \+ (L = nil, R = nil).

% count_internal_nodes(T,N) :- the binary tree T has N internal nodes

count_internal_nodes(t(_,L,R),N) :- 
  internal_node(t(_,L,R)), !, 
  count_internal_nodes(L,NL),
  count_internal_nodes(R,NR),
  N is NL + NR + 1.
count_internal_nodes(_,0).
