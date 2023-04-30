import React, { Component } from 'react';
// import logo from './logo.svg';
// import './App.css';

class ComponentDetail extends Component {
    constructor(props){
        super(props)
        this.ensembleIDClickEvent = this.ensembleIDClickEvent.bind(this)
        this.toggleContent = this.toggleContent.bind(this)
        this.state = {
            showContent: true,
            thisGene: null
        }

    }
    ensembleIDClickEvent(event){
        event.preventDefault()
        console.log(this.ensembleIDClickEvent)
        let ensemblLink = this.props.gene
        ensemblLink["ensemblID"] = "ID in the ENSEMBL database"
        
        // {
        //     ensemblID: "ID in the ENSEMBL database",
        //     geneName: this.state.thisGene.geneName,
        //     speciesName: this.state.thisGene.speciesName,
        //     source: this.state.thisGene.source
        // }
        this.setState({thisGene: ensemblLink})
        const {dataCallback} = this.props
        if (dataCallback !== undefined) {
            dataCallback("callback")
        }
    }

    toggleContent (event) {
        // prevent the default
        event.preventDefault()
        this.setState({
            showContent: !this.state.showContent
        })
    }
    componentDidMount(){
        const {gene} = this.props
        this.setState({thisGene: gene})
    }

    render () {
        const {thisGene} = this.state
        const {showContent} = this.state
        return (
            <div>
            {thisGene !== null ?
                <div>
                    <h1 onClick={this.ensembleIDClickEvent}> {thisGene.ensemblID} </h1>
                    {/* <p className={` ${showContent === true ? 'd-block' : 'd-none' }`}>{gene.geneName}</p>    */}
                    {showContent === true ? <p>{thisGene.geneName} <br></br> {thisGene.speciesName} <br></br> {thisGene.source}</p> : ""}
                    <button onClick={this.toggleContent}> Toggle content display </button>
                </div>
            : ""}
            </div>
        )
    }
 }

export default ComponentDetail;
