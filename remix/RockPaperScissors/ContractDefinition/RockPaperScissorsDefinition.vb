Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts
Imports System.Threading
Namespace Remix.Contracts.RockPaperScissors.ContractDefinition

    
    
    Public Partial Class RockPaperScissorsDeployment
     Inherits RockPaperScissorsDeploymentBase
    
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
    
    End Class

    Public Class RockPaperScissorsDeploymentBase 
            Inherits ContractDeploymentMessage
        
        Public Shared DEFAULT_BYTECODE As String = "6080604052620493e060015534801561001757600080fd5b50600080546001600160a01b03191633179055610695806100396000396000f3fe6080604052600436106100595760003560e01c8063394767871461006557806353a04b05146100905780638772ae3c146100a55780638be7b3ae146100c55780638da5cb5b146100e6578063c38a8afd1461011e57600080fd5b3661006057005b600080fd5b34801561007157600080fd5b5061007a610142565b604051610087919061058e565b60405180910390f35b6100a361009e3660046105b6565b6101b7565b005b3480156100b157600080fd5b506100a36100c03660046105de565b61050b565b3480156100d157600080fd5b5060005461007a90600160a01b900460ff1681565b3480156100f257600080fd5b50600054610106906001600160a01b031681565b6040516001600160a01b039091168152602001610087565b34801561012a57600080fd5b5061013460015481565b604051908152602001610087565b60008061015060014361060d565b60408051914060208301526bffffffffffffffffffffffff193060601b169082015260540160408051601f1981840301815291905280516020909101209050600061019c600383610626565b90508060028111156101b0576101b0610578565b9250505090565b60015434101561020e5760405162461bcd60e51b815260206004820152601960248201527f4d696e696d756d2062657420636f756c64206e6f74206d65740000000000000060448201526064015b60405180910390fd5b60015461021c906002610648565b47101561026b5760405162461bcd60e51b815260206004820181905260248201527f4e6f7420656e6f756768206d6f6e657920696e2074686520636f6e74726163746044820152606401610205565b610273610142565b6000805460ff60a01b1916600160a01b83600281111561029557610295610578565b0217905550600054600160a01b900460ff1660028111156102b8576102b8610578565b8160028111156102ca576102ca610578565b036103575760405133903480156108fc02916000818181858888f193505050501580156102fb573d6000803e3d6000fd5b50336001600160a01b03167fc62fcd128f362ffc4603c56c532db62702f0ea9dcebb620d2b02cdd58ac4e49860405161034c906020808252600490820152635469652160e01b604082015260600190565b60405180910390a250565b600081600281111561036b5761036b610578565b14801561039557506002600054600160a01b900460ff16600281111561039357610393610578565b145b806103d8575060018160028111156103af576103af610578565b1480156103d8575060008054600160a01b900460ff1660028111156103d6576103d6610578565b145b8061041c575060028160028111156103f2576103f2610578565b14801561041c57506001600054600160a01b900460ff16600281111561041a5761041a610578565b145b156104b157336108fc610430346002610648565b6040518115909202916000818181858888f19350505050158015610458573d6000803e3d6000fd5b50336001600160a01b03167fc62fcd128f362ffc4603c56c532db62702f0ea9dcebb620d2b02cdd58ac4e49860405161034c906020808252600c908201526b506c617965722077696e732160a01b604082015260600190565b336001600160a01b03167fc62fcd128f362ffc4603c56c532db62702f0ea9dcebb620d2b02cdd58ac4e49860405161034c906020808252600e908201526d506c61796572204c6f6f7365732160901b604082015260600190565b6000546001600160a01b031633146105735760405162461bcd60e51b815260206004820152602560248201527f4f6e6c7920746865206f776e65722063616e2063616c6c20746869732066756e60448201526431ba34b7b760d91b6064820152608401610205565b600155565b634e487b7160e01b600052602160045260246000fd5b60208101600383106105b057634e487b7160e01b600052602160045260246000fd5b91905290565b6000602082840312156105c857600080fd5b8135600381106105d757600080fd5b9392505050565b6000602082840312156105f057600080fd5b5035919050565b634e487b7160e01b600052601160045260246000fd5b81810381811115610620576106206105f7565b92915050565b60008261064357634e487b7160e01b600052601260045260246000fd5b500690565b8082028115828204841417610620576106206105f756fea2646970667358221220df2865eb933b8ae0fe5144b52b69cc93c9bf3d01211cbf56a9c8fa7881c5f2e064736f6c63430008130033"
        
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
        

    
    End Class    
    
    Public Partial Class GetRandomChoiceFunction
        Inherits GetRandomChoiceFunctionBase
    End Class

        <[Function]("getRandomChoice", "uint8")>
    Public Class GetRandomChoiceFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class MinimumBetFunction
        Inherits MinimumBetFunctionBase
    End Class

        <[Function]("minimumBet", "uint256")>
    Public Class MinimumBetFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class OwnerFunction
        Inherits OwnerFunctionBase
    End Class

        <[Function]("owner", "address")>
    Public Class OwnerFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class PlayFunction
        Inherits PlayFunctionBase
    End Class

        <[Function]("play")>
    Public Class PlayFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("uint8", "playerChoice", 1)>
        Public Overridable Property [PlayerChoice] As Byte
    
    End Class
    
    
    Public Partial Class RandomChoiceFunction
        Inherits RandomChoiceFunctionBase
    End Class

        <[Function]("randomChoice", "uint8")>
    Public Class RandomChoiceFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class SetMinimumBetFunction
        Inherits SetMinimumBetFunctionBase
    End Class

        <[Function]("setMinimumBet")>
    Public Class SetMinimumBetFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("uint256", "_minimumBet", 1)>
        Public Overridable Property [MinimumBet] As BigInteger
    
    End Class
    
    
    Public Partial Class GameResultEventDTO
        Inherits GameResultEventDTOBase
    End Class

    <[Event]("GameResult")>
    Public Class GameResultEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "player", 1, true)>
        Public Overridable Property [Player] As String
        <[Parameter]("string", "result", 2, false)>
        Public Overridable Property [Result] As String
    
    End Class    
    
    Public Partial Class GetRandomChoiceOutputDTO
        Inherits GetRandomChoiceOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class GetRandomChoiceOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint8", "", 1)>
        Public Overridable Property [ReturnValue1] As Byte
    
    End Class    
    
    Public Partial Class MinimumBetOutputDTO
        Inherits MinimumBetOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class MinimumBetOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class OwnerOutputDTO
        Inherits OwnerOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class OwnerOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    
    
    Public Partial Class RandomChoiceOutputDTO
        Inherits RandomChoiceOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class RandomChoiceOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint8", "", 1)>
        Public Overridable Property [ReturnValue1] As Byte
    
    End Class    
    

End Namespace
