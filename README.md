# DatePickerIssue
Steps to reproduce:
1. Launch the app
2. Select LEFT datepicker and pick future date e.g. 20/10/2023
3. Notice new Minimum RIGHT date = LEFT date, RIGHT date = LEFT date
4. Select RIGHT date picker and ensure that older date cannot be selected
5. Select LEFT datepicker and pick the date earlier than current.
6. Notice new minimum dates in the RIGHT.
7. Select RIGHT datepicker and ensure that RIGHT datepicker mininmum date doesn't match binding minimum date value  
