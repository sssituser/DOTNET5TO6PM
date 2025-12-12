import React from 'react'
import {useForm} from 'react-hook-form'
function About() {

  const{register,handleSubmit,formState:{errors}} = useForm()
  function save(data){
    alert(JSON.stringify(data))
  }
  return (
    <React.Fragment>
      <p className="h1 text-center">About</p>
      <div className="row">
        <div className="col-md-4">
          <div className="card">
            <div className="card-header bg-secondary text-white">
             <p className="h3"> Register Here</p>
            </div>
            <div className="card-body">
              <form action="" onSubmit={handleSubmit(save)}>
                <div className="form-group">
                  <input type="number"
                   className='form-control'
                   {
                    ...register('eid',{
                        required:{value:true,message:"Employee ID is Must"},
                        min:{value:100,message:"Employee ID Min value 100"},
                        max:{value:10000,message:"Max Employee id is 10000"}
                      }
                    )
                   }
                  />
                  {errors.eid && (<p className='text-danger'>{errors.eid.message}</p>)}
                </div>
                   <button className='btn btn-success btn-md'>Submit</button>
              </form>
            </div>
          </div>
        </div>
      </div>

    </React.Fragment>
  )
}

export default About