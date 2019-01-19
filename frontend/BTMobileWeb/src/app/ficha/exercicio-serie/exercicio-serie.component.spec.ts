import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ExercicioSerieComponent } from './exercicio-serie.component';

describe('ExercicioSerieComponent', () => {
  let component: ExercicioSerieComponent;
  let fixture: ComponentFixture<ExercicioSerieComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ExercicioSerieComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ExercicioSerieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
