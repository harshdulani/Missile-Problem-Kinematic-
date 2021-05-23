Problem: 
Two objects, Target and Missile start at a distance apart (h) = 40m.
Both Travel at different velocities and have difference accelerations applied to them.
How long (t) before the Missile catches up to the Target, assuming both the bodies have constant acceleration.

Solution:
Using Kinematic equations

Where,

S = displacement
U = initial velocity
V = final velocity
A = acceleration
T = time

We don't know the point at which the 2 objects (A = Target & B = Missile) will meet,
But we know that B will have to displace distance (h) and also the final displacement of A

A        B                                    x
*--------*------------------------------------*
<---h---><----final displacement of B (sb)---->
<-------sa------------------------------------>

Hence, sb = sa + h

Using SUVAT formula

S = ut + a * (t)^2 / 2

Solving this using our values and formula for displacement
S = ut + a * (t)^2 / 2

We get,

Ub * t + ab * (t)^2 / 2 = ua + aa * (t)^2 / 2 + h

Therefore,
(t)^2 * (ab - aa) + t * (2ub - 2ua) - 2h = 0

Which is in the general form of quadratic equations,
Ax^2 + bx + c = 0

X = - (b ± sqrt(b^2 - 4ac)) / 2a

And since estimated time can't be negative, we only calculate for positive and that gives us our prediction.
Implementation can be found in Timer.cs

The accuracy of the equation prediction is measured by how close the ball stops before/after the actual point of contact between the two.
Colliders are not used so as to not use Unity's rigidbody and collider physics at all and emulate them instead.