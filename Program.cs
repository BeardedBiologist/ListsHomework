/* BREIF:
 * 
 * Add students to a class roster List until there are no more students. 
 * Then print out the count of the students to the Console.
 * 
 */

string nameData = "Joshua,James,Erik,Bjorn,Alex";
List<string> studentNames = nameData.Split(',').ToList();

Console.WriteLine($"The total number of students is: {studentNames.Count()}");

