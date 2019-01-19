import { Component, OnInit } from '@angular/core';

import { FichaService}  from '../../ficha.service';

@Component({
  selector: 'app-listar',
  templateUrl: './listar.component.html',
  styleUrls: ['./listar.component.css']
})
export class Ficha_Listar implements OnInit {

  public professores: Array<any>;
  public clientes: Array<any>;

  public professorId: any;
  public clienteId: any;

  public fichas: any;

  constructor(private fichaService: FichaService) { 
    fichaService.getProfessores().subscribe((data: any) => this.professores = data);
    fichaService.getClientes().subscribe((data: any) => this.clientes = data);
  }

  ngOnInit() {
  }

  public setProfessorId = function(valor: any) {
    this.professorId = valor;
  };

  public setClienteId = function(valor: any) {
    this.clienteId = valor;
  };

  public ObterFichas = function(event) {
    this.fichaService.getFichas(this.professorId, this.clienteId).subscribe((data: any) => this.fichas = data);
  };

  public AbrirFicha = function(id: number) {
    alert("Id da ficha: " + id);
  };
}
