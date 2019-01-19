import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Ficha_Listar } from './listar.component';

describe('ListarComponent', () => {
  let component: Ficha_Listar;
  let fixture: ComponentFixture<Ficha_Listar>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Ficha_Listar ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Ficha_Listar);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
