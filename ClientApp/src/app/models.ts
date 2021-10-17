export class Postulation {
    id: number
    date: Date
    salaryAspiration: number
    role: Role
    candidate: Candidate
    evaluator: Evaluator 
    tests: Test[]
    finalStep: FinalStep
    Company: Company
}

export class Person {
    id: number
    name: string
}

export class Role extends Person {}
export class Candidate extends Person {}
export class Evaluator extends Person {}

export class Test {
    id: number
    qual: Qual
    score: number
    comment: string
}

export class Qual {
    id: number
    name: string
}

export class FinalStep {
    id: number
    avgScore: number
    agreedSalary: number
    startDate: Date
}

export class Company {
    id: number
    name: string
    postulations: Postulation[]
    Roles: Role[]
    Candidates: Candidate[]
    Evaluator: Evaluator[]
}
