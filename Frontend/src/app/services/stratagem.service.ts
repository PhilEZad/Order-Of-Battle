import { Injectable } from '@angular/core';
import { Stratagem } from "../interfaces/Stratagem";
import { mockStratagems } from "../Mock/MockStratagem";
import {Observable, of} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class StratagemService {

  constructor() { }

  getStratagems(): Stratagem[]
  {
    return mockStratagems;
  }
}
