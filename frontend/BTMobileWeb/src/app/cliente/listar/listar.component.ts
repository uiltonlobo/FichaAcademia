import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ClienteService } from 'src/app/cliente.service';

@Component({
  selector: 'app-listar',
  templateUrl: './listar.component.html',
  styleUrls: ['./listar.component.css']
})
export class Cliente_Listar implements OnInit {

  public clientes: Array<any>;

  constructor(private rt: Router, private clienteService: ClienteService) {
    this.clienteService.listar().subscribe((data: any) => this.clientes = data);
   };

  ngOnInit() {
  }

  public incluir = function(event: Event) {
    event.preventDefault();
    event.stopPropagation();

    this.rt.navigate(['/cliente', 0]);
  };

  public excluir = function(event: Event, clienteId: number) {
    event.preventDefault();
    event.stopPropagation();

    let confirmou = confirm("Deseja excluir o cliente?");

    if (confirmou) {
      this.clienteService.excluir(clienteId).subscribe((data: any) => {
        window.location.reload();
      });
    }
  };

}
