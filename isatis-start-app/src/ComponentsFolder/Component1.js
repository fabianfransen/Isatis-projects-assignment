import React, { Component } from 'react';
// import logo from './logo.svg';
// import './App.css';
import TestData from '../data/testData.json'

import ComponentDetail from './ComponentDetail';

class Component1 extends Component {
    constructor(props){
        super(props)
        this.dataCallbackHandler = this.dataCallbackHandler.bind(this)
    }
    dataCallbackHandler(text){
        // alert(text)
        // console.log(this)
    }
    render () {
        return (
            <div >
                <h1> Hello there</h1>
                {TestData.map((savedGene, index)=>{
                    return <ComponentDetail 
                    gene={savedGene} 
                    key={`gene-list-key ${index}`} 
                    dataCallback={this.dataCallbackHandler} />
                })}
            </div>
        )
    }
 } 

export default Component1;
