import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DelateStudentComponent } from './delate-student.component';

describe('DelateStudentComponent', () => {
  let component: DelateStudentComponent;
  let fixture: ComponentFixture<DelateStudentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DelateStudentComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DelateStudentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
