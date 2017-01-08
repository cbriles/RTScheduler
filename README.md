# RTScheduler
RTScheduler is a program that determines the feasibility of a Real-Time schedule for a single processor system. The user may choose between three scheduling algorithms:
* Rate Monotonic
* Earliest Deadline First
* Mixed (RM + EDF)

The user may enter their criteria for a schedule of up to 5 tasks. This includes each task's Period, Runtime, and Priority Level in the case of mixed scheduling. For the purposes of this scheduler, it is assumed that the deadline for each individual job corresponds to its task's respective period length. After the data is entered, the scheduler will attempt to draw the schedule onto the timeline and determine whether it is possible or not. If a job misses its deadline, this information will be displayed to the user.
