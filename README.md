# Mandelbrot Fractal View

## Controls

1. Reset to (0) + (0)i:
  - This button resets the focus point to the origin, re-centreing the fractal.
2. Maximum Iterations:
  - This changes the maximum amount of times the program will iterate to see if a value converges or diverges.
  - A lower value means more points will be classed as converging, losing some detail.
3. Magnitude Threshold:
  - As the program iterates the expression on any point, if the output is greater than this threshold, the point will be classed as diverging.
  - Higher threshold results in more fine detail, whilst a lower threshold gives a mmore expansive view.
4. Render Time
  - The amount of time (in milliseconds) that it takes for your computer to render the current frame.
5. Colour Shift:
  - This is purely cosmetic, and merely changes the pretty colours of the visualisation.

## About

This program allows for visualising fractals, including the mandelbrot set. To read up about fractals and specifically the mandelbrot set, I recommend reading [the wikipedia page](https://en.wikipedia.org/wiki/Mandelbrot_set).

## Limitations
1. Limited resolution
  - Due to the limited precision of floating-point types in C#, at high zoom levels, the visualisation stops working.
2. Currently only works for the mandlebrot set
  - I'm working on this feature, to allow you to input your own equations to explore.