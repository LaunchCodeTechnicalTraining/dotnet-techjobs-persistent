[Textbook Instructions](https://education.launchcode.org/csharp-web-development/assignments/tech-jobs-persistent.html)

[Starter Code](https://github.com/LaunchCodeEducation/TechJobsPersistent)

# C# Graded Assignment #4 Rubric (TechJobs, Persistent Edition)

This assignment tests the students' understandings of SQL database management and the mechanics of object relational 
mapping. Students will demonstrate their knowledge of these topics by making updates again to the TechJobs application.
They will be asked to create the database connection, finish what has been started to add ``Employer`` objects by navigating a one-to-many relationship, navigate a many-to-many relationship between ``Skills`` and ``Jobs``, and answer a few simple SQL questions.

Grading should be done via demonstrations again. Ask your students to give you a guided walkthrough of their sourcecode,
as well as their running application.

## Score your students' work based on the following criteria:

### Performance and Code Check:

1. Ask the student to start their application and navigate to the *Add Job* view.

1. Ask them to create a new employer from the form and show you the resulting object in the employer table.

1. Ask them to create at least two new skills from the form and show you the objects in the skill table.

1. Ask the student to create a new Job from the form, selecting at least two skills. 

   a. Once created, have the student show you their job table and verify that there is an ``EmployerId`` column in it.
     
   b. Have the student confirm that a mapped table is present for ``JobSkills`` and that at least two rows are now in it
      for the job just created. You can confirm the newly-created Job object's ID by checking the *List Jobs* view.
      
1. At no point should there be a table related to the ``JobField`` class. Ask the student to show you all of their
   tables in their ``techjobs`` schema to make sure that the tables in the schema include: ``Employers``, ``Jobs``, ``Skills``, and ``JobSkills``.

1. The students were asked to answer a few SQL questions and input their responses into a file in the root of the 
   project's directory called ``queries.sql``. Check their responses with the ``queries.sql`` found in this solution repo.
   It is ok if the query responses do not match exactly as long as the syntax is appropriate. 
   

## Feedback and Grades:
    
Give your student a score of 1 if they meet each the requirement above. If they are missing one of the tables, or 
their SQL responses are not sufficient, give some advice on how to correct this. Ask them if they feel there is
something blocking their success. Plan to have them demonstrate their assignment with you again when they have made 
the corrections.
