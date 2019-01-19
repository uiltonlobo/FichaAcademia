import { ExercicioService } from './../../exercicio.service';
import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-detalhe',
  templateUrl: './detalhe.component.html',
  styleUrls: ['./detalhe.component.css']
})
export class Exercicio_Detalhe implements OnInit {

  public id: number;
  public nome: string = "";

  constructor(private activatedRoute: ActivatedRoute, private route: Router, private exercicioService: ExercicioService) { 
    this.activatedRoute.params.subscribe(params => {
      if (params.id) this.id = params.id;
      
      if (this.id && this.id > 0) {
        this.exercicioService.obterPorId(this.id).subscribe((data: any) => this.nome = data.nome);
      }
    });
  }

  ngOnInit() {
  }

  public salvar = function(event: Event) {
    event.preventDefault();
    event.stopPropagation();

    if (this.id && this.id > 0) {
      this.exercicioService.alterar(this.id, this.nome, () => {
        this.route.navigate(['/exercicio']);
      });    
    }
    else {
      this.exercicioService.incluir(this.id, this.nome, () => {
        this.route.navigate(['/exercicio']);
      });    
    }
  };

  public voltar = function(event: Event) {
    event.preventDefault();
    event.stopPropagation();

    this.route.navigate(['/exercicio']);
  }; 


}
