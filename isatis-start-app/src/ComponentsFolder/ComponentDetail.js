import React, { Component } from 'react';
// import logo from './logo.svg';
// import './App.css';

class ComponentDetail extends Component {
    render () {
        const {gene} = this.props
        return (
            <div>
                <h1>{gene.ensemblID} </h1>
                <p>{gene.geneName}</p>
                <p>{gene.speciesName}</p>
                <p>{gene.source}</p>
            </div>
        )
    }
 }

export default ComponentDetail;
