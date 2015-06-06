/*
 * @(#)Graph.java	1.7 98/07/17
 *
 * Copyright (c) 1997, 1998 Sun Microsystems, Inc. All Rights Reserved.
 *
 * Sun grants you ("Licensee") a non-exclusive, royalty free, license to use,
 * modify and redistribute this software in source and binary code form,
 * provided that i) this copyright notice and license appear on all copies of
 * the software; and ii) Licensee does not utilize the software in a manner
 * which is disparaging to Sun.
 *
 * This software is provided "AS IS," without a warranty of any kind. ALL
 * EXPRESS OR IMPLIED CONDITIONS, REPRESENTATIONS AND WARRANTIES, INCLUDING ANY
 * IMPLIED WARRANTY OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE OR
 * NON-INFRINGEMENT, ARE HEREBY EXCLUDED. SUN AND ITS LICENSORS SHALL NOT BE
 * LIABLE FOR ANY DAMAGES SUFFERED BY LICENSEE AS A RESULT OF USING, MODIFYING
 * OR DISTRIBUTING THE SOFTWARE OR ITS DERIVATIVES. IN NO EVENT WILL SUN OR ITS
 * LICENSORS BE LIABLE FOR ANY LOST REVENUE, PROFIT OR DATA, OR FOR DIRECT,
 * INDIRECT, SPECIAL, CONSEQUENTIAL, INCIDENTAL OR PUNITIVE DAMAGES, HOWEVER
 * CAUSED AND REGARDLESS OF THE THEORY OF LIABILITY, ARISING OUT OF THE USE OF
 * OR INABILITY TO USE SOFTWARE, EVEN IF SUN HAS BEEN ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGES.
 *
 * This software is not designed or intended for use in on-line control of
 * aircraft, air traffic, aircraft navigation or aircraft communications; or in
 * the design, construction, operation or maintenance of any nuclear
 * facility. Licensee represents and warrants that it will not use or
 * redistribute the Software for such purposes.
 */

import java.util.*;
import java.awt.*;
import java.applet.Applet;
import java.awt.event.*;


class Node {
    double x;
    double y;

    double dx;
    double dy;

    boolean fixed;

    String lbl;
}


class Edge {
    int from;
    int to;

    double len;
}


class GraphPanel extends Panel
    implements Runnable, MouseListener, MouseMotionListener {

    Graph graph;
    int nnodes;
    Node nodes[] = new Node[100];

    int nedges;
    Edge edges[] = new Edge[200];

    Thread relaxer;
    boolean stress;
    boolean random;

    GraphPanel(Graph graph) {
        this.graph = graph;
        addMouseListener(this);
    }

    int findNode(String lbl) {
        for (int i = 0 ; i < nnodes ; i++) {
            if (nodes[i].lbl.equals(lbl)) {
                return i;
            }
        }
        return addNode(lbl);
    }
    int addNode(String lbl) {
        Node n = new Node();
        n.x = 10 + 380*Math.random();
        n.y = 10 + 380*Math.random();
        n.lbl = lbl;
        nodes[nnodes] = n;
        return nnodes++;
    }
    void addEdge(String from, String to, int len) {
        Edge e = new Edge();
        e.from = findNode(from);
        e.to = findNode(to);
        e.len = len;
        edges[nedges++] = e;
    }

    public void run() {
        Thread me = Thread.currentThread();
        repaint();
        while (relaxer == me) {
            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                break;
            }
        }
    }

    Node pick;
    boolean pickfixed;
    Image offscreen;
    Dimension offscreensize;
    Graphics offgraphics;

    final Color fixedColor = Color.red;
    final Color selectColor = Color.pink;
    final Color edgeColor = Color.black;
    final Color nodeColor = new Color(250, 220, 100);
    final Color stressColor = Color.darkGray;
    final Color arcColor1 = Color.black;
    final Color arcColor2 = Color.pink;
    final Color arcColor3 = Color.red;

    public void paintNode(Graphics g, Node n, FontMetrics fm) {
        int x = (int)n.x;
        int y = (int)n.y;
        g.setColor((n == pick) ? selectColor : (n.fixed ? fixedColor : nodeColor));
        int w = fm.stringWidth(n.lbl) + 10;
        int h = fm.getHeight() + 4;
        g.fillRect(x - w/2, y - h / 2, w, h);
        g.setColor(Color.black);
        g.drawRect(x - w/2, y - h / 2, w-1, h-1);
        g.drawString(n.lbl, x - (w-10)/2, (y - (h-4)/2) + fm.getAscent());
    }

    public synchronized void update(Graphics g) {
        Dimension d = getSize();
        if ((offscreen == null) || (d.width != offscreensize.width) || 
            (d.height != offscreensize.height)) {
            offscreen = createImage(d.width, d.height);
            offscreensize = d;
            offgraphics = offscreen.getGraphics();
            offgraphics.setFont(getFont());
        }

        offgraphics.setColor(getBackground());
        offgraphics.fillRect(0, 0, d.width, d.height);
        for (int i = 0 ; i < nedges ; i++) {
            Edge e = edges[i];
            int x1 = (int)nodes[e.from].x;
            int y1 = (int)nodes[e.from].y;
            int x2 = (int)nodes[e.to].x;
            int y2 = (int)nodes[e.to].y;
            int len = (int)Math.abs(Math.sqrt((x1-x2)*(x1-x2) + 
                                              (y1-y2)*(y1-y2)) - e.len);
            offgraphics.setColor((len < 10) ? arcColor1 : 
                                 (len < 20 ? arcColor2 : arcColor3)) ;
            offgraphics.drawLine(x1, y1, x2, y2);
            if (stress) {
                String lbl = String.valueOf(len);
                offgraphics.setColor(stressColor);
                offgraphics.drawString(lbl, x1 + (x2-x1)/2, y1 + (y2-y1)/2);
                offgraphics.setColor(edgeColor);
            }
        }

        FontMetrics fm = offgraphics.getFontMetrics();
        for (int i = 0 ; i < nnodes ; i++) {
            paintNode(offgraphics, nodes[i], fm);
        }
        g.drawImage(offscreen, 0, 0, null);
    }

    //1.1 event handling
    public void mouseClicked(MouseEvent e) {
    }

    public void mousePressed(MouseEvent e) {
        addMouseMotionListener(this);
        double bestdist = Double.MAX_VALUE;
        int x = e.getX();
        int y = e.getY();
        for (int i = 0 ; i < nnodes ; i++) {
            Node n = nodes[i];
            double dist = (n.x - x) * (n.x - x) + (n.y - y) * (n.y - y);
            if (dist < bestdist) {
                pick = n;
                bestdist = dist;
            }
        }
        pickfixed = pick.fixed;
        pick.fixed = true;
        pick.x = x;
        pick.y = y;
        repaint();
        e.consume();
    }

    public void mouseReleased(MouseEvent e) {
        removeMouseMotionListener(this);
        pick.x = e.getX();
        pick.y = e.getY();
        pick.fixed = pickfixed;
        pick = null;
        repaint();
        e.consume();
    }

    public void mouseEntered(MouseEvent e) {
    }

    public void mouseExited(MouseEvent e) {
    }

    public void mouseDragged(MouseEvent e) {
        pick.x = e.getX();
        pick.y = e.getY();
        repaint();
        e.consume();
    }

    public void mouseMoved(MouseEvent e) {
    }

    public void start() {
        relaxer = new Thread(this);
        relaxer.start();
    }

    public void stop() {
        relaxer = null;
    }
}

public class Graph extends Applet implements ActionListener, ItemListener {

    GraphPanel panel;

    public void init() {
        setLayout(new BorderLayout());

        panel = new GraphPanel(this);
        add("Center", panel);

        String edges = getParameter("edges");
        for (StringTokenizer t = new StringTokenizer(edges, ","); 
             t.hasMoreTokens() ; ) {
            String str = t.nextToken();
            int i = str.indexOf('-');
            if (i > 0) {
                int len = 50;
                String fromString = str.substring(0,i).trim();
                String toString = str.substring(i+1).trim();
                panel.addEdge(fromString, toString, len);
            }
        }
    }

    public void destroy() {
        remove(panel);
    }

    public void start() {
        panel.start();
    }

    public void stop() {
        panel.stop();
    }

    public void actionPerformed(ActionEvent e) {
    }

    public void itemStateChanged(ItemEvent e) {
    }

    public String getAppletInfo() {
        return "Title: GraphLayout";
    }

    public String[][] getParameterInfo() {
        String[][] info = {
            {"edges", "delimited string", 
             "A comma-delimited list of all the edges. It takes the form "+
             "of 'N1-N2,N2-N3,...' where NX is a node attached to the center "+
             "node."},
        };
        return info;
    }

}
