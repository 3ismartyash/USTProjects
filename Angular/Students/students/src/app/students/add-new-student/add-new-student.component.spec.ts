import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddNewStudentComponent } from './add-new-student.component';

describe('AddNewStudentComponent', () => {
  let component: AddNewStudentComponent;
  let fixture: ComponentFixture<AddNewStudentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddNewStudentComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddNewStudentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
