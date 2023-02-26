import 'bootstrap/dist/css/bootstrap.css';
import './App.css';

const App = () => {
  return (
    <div className='App'>
      <header>
        <img
          src='globo.png'
          height='180'
          alt='Globomantics'
          className='img-fluid'
        />
      </header>
      <main>
        <div className='container'>
          <div className='row well mb-3'>
            <div className='col-md-3 col-sm-3'>
              <button
                type='button'
                className='btn btn-secondary btn-lg disabled'
              >
                Add Inventory
              </button>
            </div>
            <div className='col-md-3 col-sm-3'>
              <button
                type='button'
                className='btn btn-secondary btn-lg disabled'
              >
                Check Inventory
              </button>
            </div>
            <div className='col-md-3 col-sm-3'>
              <button
                type='button'
                className='btn btn-secondary btn-lg disabled'
              >
                Sell Items
              </button>
            </div>
          </div>

          <div className='row well mb-3'>
            <div className='col-md-6'>
              <h5>There are 8 items in the inventory!!</h5>
            </div>
          </div>
        </div>
      </main>
    </div>
  );
};

export default App;
