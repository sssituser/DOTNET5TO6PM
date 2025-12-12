import React from "react";

export default function HCards(){
    return(
        <React.Fragment>
            <div className="container">
                <div className="card mt-5">
                    <div className="card-body">
                        <div className="row">
                            <div className="col-md-4">
                                <img src={"https://i.pinimg.com/736x/55/1b/d7/551bd72fd368e5459e4d8cc76e9db982--bollywood-news-bollywood-stars.jpg"}  width={300} className="img-fluid" alt="" />
                            </div>
                            <div className="col-md-8">
                                <p className="lead">
                                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsam at nostrum, facere, accusamus voluptatibus neque suscipit laudantium aliquid quis quidem unde autem inventore blanditiis accusantium qui ipsa ad repellendus ducimus voluptas fuga obcaecati eius! Possimus iure hic ut ipsum, est atque sunt voluptatibus iste necessitatibus ullam repellendus maiores fugit magnam asperiores minus quam delectus, cupiditate autem doloribus, praesentium placeat dolores.
                                </p>
                                <button className="btn btn-md btn-primary">Read More</button>
                            </div>
                        </div>
                    </div>
                </div>

<div className="card mt-5">
                    <div className="card-body">
                        <div className="row">
                            <div className="col-md-4">
                                <img src={"https://stat5.bollywoodhungama.in/wp-content/uploads/2025/04/Ranveer-Singh-Shahid-Kapoor-Aamir-Khan-John-Abraham-Saif-Ali-Khan-and-now-Vijay-aut70.jpg"}  width={300} className="img-fluid" alt="" />
                            </div>
                            <div className="col-md-8">
                                <p className="lead">
                                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsam at nostrum, facere, accusamus voluptatibus neque suscipit laudantium aliquid quis quidem unde autem inventore blanditiis accusantium qui ipsa ad repellendus ducimus voluptas fuga obcaecati eius! Possimus iure hic ut ipsum, est atque sunt voluptatibus iste necessitatibus ullam repellendus maiores fugit magnam asperiores minus quam delectus, cupiditate autem doloribus, praesentium placeat dolores.
                                </p>
                                <button className="btn btn-md btn-primary">Read More</button>
                            </div>
                        </div>
                    </div>
                </div>
                
            </div>
        </React.Fragment>
    )
}