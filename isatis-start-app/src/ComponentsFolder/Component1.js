import React, { Component } from 'react';
// import logo from './logo.svg';
// import './App.css';
import TestData from '../data/testData.json'

class Component1 extends Component {
    render () {
        return (
            <div >
                <h1> Hello there</h1>
                {TestData.map((savedGene, index)=>{
                    return <h1>{savedGene.ensemblID} </h1>
                })}
            </div>
        )
    }
 }

export default Component1;
