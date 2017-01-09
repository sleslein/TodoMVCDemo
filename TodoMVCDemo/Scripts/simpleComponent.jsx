const HelloMessage = React.createClass({
    getInitialState () {
        return {
            name: this.props.name
        };
    },
    clickHandler() {        
        const txtNewName = document.getElementById("newName");
        const newName = txtNewName.value;
        txtNewName.value = "";
        this.setState({ name: newName });
    },
    render() {
        return (
            <div>
                <div>Name: {this.state.name}</div>
                <div>
                    New Name: <input type="text" id="newName" />
                    <button type="button" onClick={this.clickHandler}>{this.props.buttonName}</button>
                </div>
            </div>
            );
        }
    });

ReactDOM.render(
    <HelloMessage name="Bala" buttonName="Update Info" />, 
    document.getElementById('simpleComponent')
);