import React, { Component } from 'react';
// import logo from './logo.svg';
// import './App.css';

class ComponentDetail extends Component {
    constructor(props){
        super(props)
        this.ensembleIDClickEvent = this.ensembleIDClickEvent.bind(this)
    }
    ensembleIDClickEvent(event){
        event.preventDefault()
        console.log(this.ensembleIDClickEvent)
        const {dataCallback} = this.props
        if (dataCallback !== undefined) {
            dataCallback("callback")
        }
    }
    render () {
        const {gene} = this.props
        return (
            <div>
                <h1 onClick={this.ensembleIDClickEvent}> {gene.ensemblID} </h1>
                <p>{gene.geneName}</p>
                <p>{gene.speciesName}</p>
                <p>{gene.source}</p>
            </div>
        )
    }
 }

export default ComponentDetail;
