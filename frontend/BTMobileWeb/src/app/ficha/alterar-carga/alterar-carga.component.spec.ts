import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Ficha_AlterarCarga } from './alterar-carga.component';

describe('AlterarCargaComponent', () => {
  let component: Ficha_AlterarCarga;
  let fixture: ComponentFixture<Ficha_AlterarCarga>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Ficha_AlterarCarga ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Ficha_AlterarCarga);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
