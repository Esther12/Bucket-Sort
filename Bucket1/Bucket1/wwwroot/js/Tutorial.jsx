class SortBox extends React.Component {
    render() {
        return React.createElement(
            <div>
                <h3>Insert the Integers</h3>
                <SortForm/>
            </div>
        );
    }
}

ReactDOM.render(
    React.createElement(SortBox, null),
    document.getElementById('content'),
);



//=======================Sort Form =======================
class SortForm extends React.Component {     constructor(props) {         super(props);         this.state = { data: [] };         this.handleInputChange = this.handleInputChange.bind(this);         this.handleSubmit = this.handleSubmit.bind(this);     }     handleInputChange(e) {         this.setState({ input: e.target.value });     }     handleSubmit(e) {         e.preventDefault();         const input = this.state.input.trim();         const display = this.state.display.trim();         if (!input) {             return;         }         // TODO: send request to the server         this.props.onCommentSubmit({ Input: input, Display: diaplay });         this.setState({ input: '', display: '' });     }     render() {         return (             <form className="commentForm" onSubmit={ this.handleSubmit}>                 <input                     type="text"                     placeholder="Insert integers splite with , "                     value={ this.state.input}                     onChange={ this.handleInputChange}                 />                                 <input type="submit" value="Post" />             </form>         );     } }