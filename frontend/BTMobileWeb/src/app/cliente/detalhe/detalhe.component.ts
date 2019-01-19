import { ClienteService } from './../../cliente.service';
import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-detalhe',
  templateUrl: './detalhe.component.html',
  styleUrls: ['./detalhe.component.css']
})
export class Cliente_Detalhe implements OnInit {

  public id: number;
  public nome: string = "";

  constructor(private activatedRoute: ActivatedRoute, private route: Router, private clienteService: ClienteService) { 
    this.activatedRoute.params.subscribe(params => {
      if (params.id) this.id = params.id;
      
      if (this.id && this.id > 0) {
        this.clienteService.obterPorId(this.id).subscribe((data: any) => this.nome = data.nome);
      }
    });
  }

  ngOnInit() {
  }

  public salvar = function(event: Event) {
    event.preventDefault();
    event.stopPropagation();

    if (this.id && this.id > 0) {
      this.clienteService.alterar(this.id, this.nome, () => {
        this.route.navigate(['/cliente']);
      });    
    }
    else {
      this.clienteService.incluir(this.id, this.nome, () => {
        this.route.navigate(['/cliente']);
      });    
    }
  };

  public voltar = function(event: Event) {
    event.preventDefault();
    event.stopPropagation();

    this.route.navigate(['/cliente']);
  }; 


}
