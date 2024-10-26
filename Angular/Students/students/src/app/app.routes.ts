import { Routes } from '@angular/router';
import { StudentsComponent } from './students/students.component';
import { AddNewStudentComponent } from './students/add-new-student/add-new-student.component';
import { DelateStudentComponent } from './students/delate-student/delate-student.component';
import { StudentDetailsComponent } from './students/student-details/student-details.component';
import { StudentListComponent } from './students/student-list/student-list.component';
import { UpdateStudentComponent } from './students/update-student/update-student.component';

export const routes: Routes = [
    {path: 'students', component: StudentsComponent},
    {path: 'studentlist', component: StudentListComponent},
    {path: 'addnewstudent', component: AddNewStudentComponent},
    {path: 'studentdetails', component: StudentDetailsComponent},
    {path: 'updateStudent', component: UpdateStudentComponent},
    {path: 'deleteStudent', component: DelateStudentComponent},

    {path: '', redirectTo: '/students', pathMatch: 'full'},

];
