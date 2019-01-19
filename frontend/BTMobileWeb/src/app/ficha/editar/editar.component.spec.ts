import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Ficha_Editar } from './editar.component';

describe('EditarComponent', () => {
  let component: Ficha_Editar;
  let fixture: ComponentFixture<Ficha_Editar>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Ficha_Editar ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Ficha_Editar);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
