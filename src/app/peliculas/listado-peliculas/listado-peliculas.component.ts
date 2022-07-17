import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-listado-peliculas',
  templateUrl: './listado-peliculas.component.html',
  styleUrls: ['./listado-peliculas.component.css']
})
export class ListadoPeliculasComponent implements OnInit {

  constructor() { }
  @Input()
  peliculas: Array<any>;

  ngOnInit(): void {
  }

  remover(index: number){
     this.peliculas.splice(index,1);
  }

} 
