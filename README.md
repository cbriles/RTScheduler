# RTScheduler
This program was written as an assignment from CS Senior Seminar. The assignment was: *Determine the pros and cons of the Rate Monotonic and Earliest Deadline First scheduling algorithms by simulation. If possible, combine the benefits of both.*

I have approached the problem by utilizing the rich features of C#, including GUI features and LINQ. The tasks are represented as a class, with each task instance being an object of that class. All of the tasks are then added to a list.

The core of the program revolves around the following sorts, which utilize LINQ features:
```
List<Task> tasksSortedByPriority = tasks.OrderBy(x => x.PriorityLevel).ToList();
List<Task> tasksSortedByEDF = tasks.OrderBy(x => x.Period - (i % x.Period)).ThenByDescending(x => x.Period).ToList();
List<Task> tasksSortedByMP = tasks.OrderBy(x => x.PriorityLevel).ThenBy(x => x.Period - (i % x.Period)).ThenByDescending(x => x.Period).ToList();
```
These sorts allow for the corresponding properties to their algorithm counterparts. RMS sorts by priority; EDF sorts by time to deadline; and mixed sorts by priority, then time to deadline.

## Usage
RTScheduler is a program that determines the feasibility of a Real-Time schedule for a single processor system. The user may choose between three scheduling algorithms:
* Rate Monotonic
* Earliest Deadline First
* Mixed (RM + EDF)

The user may enter their criteria for a schedule of up to 5 tasks. This includes each task's Period, Runtime, and Priority Level in the case of mixed scheduling. For the purposes of this scheduler, it is assumed that the deadline for each individual job corresponds to its task's respective period length. After the data is entered, the scheduler will attempt to draw the schedule onto the timeline and determine whether it is possible or not. If a job misses its deadline, this information will be displayed to the user.
